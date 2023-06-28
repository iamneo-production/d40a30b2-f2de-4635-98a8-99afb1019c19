import './App.css';
import Login from './Login/Login';
import 'bootstrap/dist/css/bootstrap.min.css'
import Signup from './Signup/Signup';
import "/home/coder/project/workspace/reactapp/src/Login/Login.css";
import "/home/coder/project/workspace/reactapp/src/Signup/Signup.css";
import {BrowserRouter, Routes, Route} from 'react-router-dom'
function App() {
  return (
    <BrowserRouter>
    <Routes>
      <Route path='/' element={<Login />}></Route>
        <Route path='/login' element={<Login />}></Route>
        <Route path='/signup' element={<Signup />}></Route>
    </Routes>
    </BrowserRouter>
  );
}

export default App;
