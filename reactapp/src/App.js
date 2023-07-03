import Login from "./components/Login/Login";
import Signup from "./components/Signup/Signup"
import "./components/Signup/Signup.css"
import './components/Login/Login.css'
import 'bootstrap/dist/css/bootstrap.min.css'
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