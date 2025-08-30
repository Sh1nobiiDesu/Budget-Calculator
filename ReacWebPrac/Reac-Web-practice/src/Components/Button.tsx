import React from 'react'
import './Button.css'
import { Link } from 'react-router-dom';

interface btnProps{
    children : string
    btnType? : 'submit' | 'reset' | 'button'  
    onClick? : () => void
    buttonStyle? : string
    buttonSize? : string
}

const btnStyles = ['btn--primary', 'btn--outline']

const btnSizes = ['btn--medium', 'btn--large']


export const Button = ({children ,btnType = 'button' , onClick, buttonStyle = btnStyles[0] , buttonSize = btnSizes[0]} : btnProps) => {

    return(
        <Link to='/' className='btn-mobile'>
            <button className={`btn ${buttonStyle} ${buttonSize}`} onClick={() => onClick} type={btnType}>
                {children}
            </button>
        </Link>
    )
}
