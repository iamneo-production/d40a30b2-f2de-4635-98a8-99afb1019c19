import sql from "mssql";
import cors from 'cors';
import express from "express";

const app = express();
app.use(cors());
app.use(express.json());

const config = {
    user: "sa",
    password: "examlyMssql@123",
    server: "localhost",
    database: "boxingacademy",
    options: {
        trustServerCertificate: true,    },
};

sql.connect(config)
    .then(() => {
        console.log("MSSQL Server Connected");
    })
    .catch((err) => {
        console.log("Error in Connection:", err);
    });
    app.post('/login', (req, res) => {
        const sql = 'SELECT * FROM login Where email=? AND password=?';
        con.query(sql, [req.body.email, req.body.password], (err, result) => {
            if(err) return res.json({Status: "Error", Error: "Error in runnig query"});
            if(result.length > 0) { 
                return res.json({Status: "Success"})
            } else {
                return res.json({Status: "Error", Error: "Wrong Email or Password"});
            }
        })
    })
    
    app.post('/signup', (req, res) => {
        const sql = "INSERT INTO login(`email`,`password`,`username`,`mobileNumber`) VALUES (?)";
        const values=[
            req.body.email,
            req.body.password,
            req.body.username,
            req.body.mobileNumber,
            req.body.userRole
        ]
        con.query(sql,[values],(err,data)=> {
            if(err) {
                return res.json("Error");
            }
            return res. json(data);
        })
    }) 

app.listen(3001, () => {
    console.log('Server started on port 3001');
});
