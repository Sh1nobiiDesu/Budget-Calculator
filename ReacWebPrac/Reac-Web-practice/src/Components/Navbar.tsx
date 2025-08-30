import React, { useState } from "react";
import "./Navbar.css";
import { Link } from "react-router-dom";
import { Button } from "./Button";

function Navbar() {

  const [click, menuClick] = useState(false);
  const [button, setButton] = useState(true);

  return (
    <>
      <nav className="navbar">
        <div className="navbar-container">
          <Link to="/" className="navbar-logo">
            TRVL <i className="fab fa-typo3"></i>
          </Link>

          <div className="menu-icon" onClick={() => menuClick(!click)}>
            <i className={click ? "fas fa-times" : "fa fa-bars"}></i>
          </div>

          <ul className={click ? "nav-menu active" : "nav-menu"}>
            <li className="nav-item">
              <Link
                to="/"
                className="nav-links"
                onClick={() => menuClick(false)}
              >
                Home
              </Link>
            </li>

            <li className="nav-item">
              <Link
                to="/"
                className="nav-links"
                onClick={() => menuClick(false)}
              >
                Services
              </Link>
            </li>

            <li className="nav-item">
              <Link
                to="/"
                className="nav-links"
                onClick={() => menuClick(false)}
              >
                Products
              </Link>
            </li>
          </ul>
          {button && <Button > SIGN UP</Button>}
        </div>
      </nav>
    </>
  );
}

export default Navbar;
