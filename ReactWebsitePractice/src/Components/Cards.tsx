import React from 'react'
import CardItem from './CardItem'
import './Cards.css'

function Cards({}) {
  return (
    <div className='cards'>
        <h1>Check out these epic destinations</h1>
        <div className="cards__container">
            <div className="cards__wrapper">
                <ul className="cards__items">
                    <CardItem src="images/akubg2.jpeg" text="Explore the world of akutan :3" label="adventure" path="/services" />
                    <CardItem src="images/Aqua Minato.jpeg" text="Explore the world of akutan :3" label="adventure" path="/services" />
                </ul>
                <ul className="cards__items">
                    <CardItem src="images/akubg2.jpeg" text="Explore the world of akutan :3" label="adventure" path="/services" />
                    <CardItem src="images/Aqua Minato.jpeg" text="Explore the world of akutan :3" label="adventure" path="/services" />
                    <CardItem src="images/akusticker.png" text="Explore the world of akutan :3" label="adventure" path="/services" />
                </ul>
            </div>
        </div>
    </div>
  )
}

export default Cards