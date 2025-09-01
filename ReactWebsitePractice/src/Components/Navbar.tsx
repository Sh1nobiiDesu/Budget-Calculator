import React, { useEffect, useState } from "react";
import "./Navbar.css";
import { Link } from "react-router-dom";
import { Button } from "./Button";

function Navbar() {

  const [click, menuClick] = useState(false);
  const [button, setButton] = useState(true);

  const handleMenuClick = () => menuClick(!click)
  const closeMobileMenu = () => menuClick(false)

  const showButton = () => { 
    // Check if window is in mobile mode
    if(window.innerWidth <= 960)
      setButton(false)
    else
      setButton(true)
  };

  //useEffect iis basically run this after this render (second parameter), [] means to run once on load. 
  // First parameter is what you want to run after a render
  useEffect(() =>{
    showButton()
  },[]);

  //Checks if whenever window is resized
  window.addEventListener('resize',showButton);
  

  return (
    <>
      <nav className="navbar">
        <div className="navbar-container">

          <Link to="/" className="navbar-logo" onClick={closeMobileMenu }>
            TRVL <i className="fab fa-typo3"></i>
          </Link>

          {/* MENU */}
          <div className="menu-icon" onClick={handleMenuClick}>
            <i className={click ? "fas fa-times" : "fa fa-bars"}></i>
          </div>

          {/* HOME Nav */}
          <ul className={click ? "nav-menu active" : "nav-menu"}>
            <li className="nav-item">
              <Link
                to="/"
                className="nav-links"
                onClick={closeMobileMenu}
              >
                Home
              </Link>
            </li>

          {/* SERVICES Nav */}
            <li className="nav-item">
              <Link
                to="/Services"
                className="nav-links"
                onClick={closeMobileMenu}
              >
                Services
              </Link>
            </li>

          {/* PRODUCTS Nav */}
            <li className="nav-item">
              <Link
                to="/Products"
                className="nav-links"
                onClick={closeMobileMenu}
              >
                Products
              </Link>
            </li>
          </ul>
          {button && <Button buttonStyle="btn--outline"> SIGN UP</Button>}
        </div>
      </nav>
    </>
  );
}

export default Navbar;
