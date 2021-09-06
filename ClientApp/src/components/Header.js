import React, { Component } from 'react';
import {Link} from "react-router-dom";
import logo from '../images/logo.png';
import banner from '../images/banner.png'
export class Header extends Component {
    render() {
        return (
            <>
            
                <div className="headr">
                    <div className="container">
                    <div className="pull-left"><img src={logo} style={{ width: "130px" }} /></div>
                        <div className="text-right menu brand"> 
                        <Link to="/">Home</Link> | <Link to="/about">About Us</Link> | 
                        <Link to="/product">Advertise</Link> | <Link to="/about">Join Now</Link> | <Link to="/about">Contact Us</Link> 
                        </div>
                            <div className="pull-right"><img src={banner} style={{ width: "728px", float:"right", margin:"0px 0 10px 0",border:"1px solid #eeeeee" }}  /></div>
                    </div>
                </div>

            </>
        )
    }
}
