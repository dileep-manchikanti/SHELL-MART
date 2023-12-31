import './App.css';
import { BrowserRouter, Route, Routes,Link } from 'react-router-dom';

import SignIn from './components/signIn';
import Navbar from './components/Navbar';
import SignUp from './components/signUp';
import Categories from './components/categories';
import Products from './components/products';
import Data from './components/data';
import Profile from './components/profile';
import Cart from './components/cart';
import Product from './components/product';

function App() {
  return (
    <BrowserRouter>
      <Routes>
          <Route path="/" exact  element={<SignIn />}/>
          <Route path="/signUp" element={<SignUp />} />
          <Route path="/categories" element={<Categories />} />
          <Route path="/products" element={<Products/>} />
          <Route path="/data" element={<Data />} />
          <Route path="/profile" element={<Profile />} />
          <Route path="/cart" element={<Cart />} />
          <Route path="/product/" element={<Product />} />
      </Routes>
    </BrowserRouter>
  ); 
}
export default App;
