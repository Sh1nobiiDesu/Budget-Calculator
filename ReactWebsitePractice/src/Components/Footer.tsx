import React from 'react'
import { Button } from './Button'
import './Footer.css'
import { Link } from 'react-router-dom'

function Footer() {
  return (
    <div className='footer-container'>
        <section className="footer-subscription">
            <p className="footer-subscription-heading">
                Join the Crew
            </p>
            <p className="footer-subscription-text">
                you can unsub at any time (pls dont)
            </p>
            <div className="input-areas">
                <form action="">
                    <input type="email" name='email' placeholder='Your email' className="footer-input" /> 
                    <Button buttonStyle='btn--outline'>Subscribe</Button>
                </form>
            </div>
        </section>
        <div className="footer-links">
            <div className="footer-link-wrapper">
                <div className="footer-link-items">
                    <h2>about us</h2>
                    <Link to='/signup'>Abouttt</Link>
                    <Link to='/'>Testimonial</Link>
                    <Link to='/'>awawa</Link>
                </div>
            </div>
            <div className="footer-link-wrapper">
                <div className="footer-link-items">
                    <h2>about us</h2>
                    <Link to='/signup'>Abouttt</Link>
                    <Link to='/'>Testimonial</Link>
                    <Link to='/'>awawa</Link>
                </div>
            </div>
        </div>
        <section className="social-media">
            <div className="social-media-wrap">
                <div className="footer-logo">
                <Link to='/' className='social-logo'>
                    TRVL <i className="fab fa-typo3" />
                </Link>
                </div>
                <small className="website-rights">TRVL copyright</small>
                <div className="social-icons">
                    <Link to='/' target='_blank' aria-label='Facebook' className="social-icon-link facebook">
                        <i className="fab fa-facebook-f"></i>
                    </Link>
                    <Link to='/' target='_blank' aria-label='Instagram' className="social-icon-link instagram">
                        <i className="fab fa-instagram"></i>
                    </Link>
                </div>
            </div>
        </section>
    </div>
  )
}

export default Footer