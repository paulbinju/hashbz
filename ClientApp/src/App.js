import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import Product from './components/Product';
import {Header} from './components/Header';
import {Footer} from './components/Footer';
 

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Header/>
       <div style={{minHeight:"500px"}} className="container">
        <Route exact path='/' component={Home} />
        <Route exact path='/product' component={Product} />
 

        </div>
        <Footer/>
      </Layout>
    );
  }
}
