<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
import Login from "./components/Login/Login";
import Signup from "./components/Signup/Signup"
import "./components/Signup/Signup.css"
import './components/Login/Login.css'
import 'bootstrap/dist/css/bootstrap.min.css'
import {BrowserRouter, Routes, Route} from 'react-router-dom'
import Adminacademy from "./components/Admin/Academy/Adminacademy";
import Viewacademy from "./components/Customer/Academy/Viewacademy";
import Addacademy from "./components/Admin/Academy/addAcademy";
import Editacademy from "./components/Admin/Academy/Editacademy";
import Admincourse from "./components/Admin/Course/Admincourse";
import Addcourse from "./components/Admin/Course/Addcourse";
import Editcourse from "./components/Admin/Course/Editcourse";
import Enrollcourse from "./components/Customer/Enroll/Enrollcourse";
import Adminstudent from "./components/Admin/Students/Adminstudent";
import Enrollform from "./components/Customer/Enroll/Enrollform";
import Enrolledcourse from "./components/Customer/Enroll/Enrolledcourse";
import Editstudent from "./components/Admin/Students/Editstudent";
import Addstudent from "./components/Admin/Students/Addstudent";
function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Login />}></Route>
          <Route path='/login' element={<Login />}></Route>
          <Route path='/signup' element={<Signup />}></Route>
          <Route path='/academy' element={<Adminacademy />}></Route>
          <Route path='/viewacademy' element={<Viewacademy />}></Route>
          <Route path='/addacademy' element={<Addacademy />}></Route>
          <Route path='/admincourse' element={<Admincourse />}></Route>
          <Route path='/addcourse' element={<Addcourse />}></Route>
          <Route path='/enrollcourse' element={<Enrollcourse />}></Route>
          <Route path='/adminstudents' element={<Adminstudent />}></Route>
          <Route path='/enrollform/:id' element={<Enrollform />}></Route>
          <Route path='/editacademy/:id' element={<Editacademy />}></Route>
          <Route path='/editcourse/:id' element={<Editcourse />}></Route>
          <Route path='/enrolledcourse' element={<Enrolledcourse />}></Route>
          <Route path='/addcourse' element={<Addcourse />}></Route>
          <Route path='/editstudent/:id' element={<Editstudent />}></Route>
          <Route path='/addstudent' element={<Addstudent />}></Route>

      </Routes>
    </BrowserRouter>
=======
>>>>>>> d42c4f7d2b0f1ae81858fc6429f5be4273e12dd8
>>>>>>> 81df1519f5cb208c75ac956de6661e9c7db428f3
import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header>
    </div>
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
>>>>>>> parent of 725dcb3 (Revert " initial commit")
>>>>>>> d42c4f7d2b0f1ae81858fc6429f5be4273e12dd8
>>>>>>> 81df1519f5cb208c75ac956de6661e9c7db428f3
  );
}

export default App;
