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

app.listen(3001, () => {
    console.log('Server started on port 3001');
});
