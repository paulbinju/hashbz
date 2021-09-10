import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import Product from './components/Product';
import {Header} from './components/Header';
import {Footer} from './components/Footer';
import ProductAdd from './components/ProductAdd';
 import ProductEdit from './components/ProductEdit';

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
        <Route exact path='/productadd' component={ProductAdd} />
        <Route exact path='/productedit' component={ProductEdit} />
 

        </div>
        <Footer/>
      </Layout>
    );
  }
}
