import Navbar from './Components/Navbar'
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import './App.css'
import Home from './Components/Pages/Home'
import Services from './Components/Pages/Services'
import SignUp from './Components/Pages/SignUp'
import Products from './Components/Pages/Products'

function App() {
  return (
    <>
      <Router>
        <Navbar />
          <Routes>
            <Route path='/' Component={Home} />
            <Route path='/Products' Component={Products} />
            <Route path='/Services' Component={Services} />
            <Route path='/SignUp' Component={SignUp} />
          </Routes>
      </Router>
    </>
  )
}

export default App
