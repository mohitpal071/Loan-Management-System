import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import styles from './NavBar.module.css';
import React from 'react';

function NavBar() {
  return (
    <>
      <Navbar className={styles.navbar}>
          <div className={styles.header}>
          <img src="./assets/wells.png" width={50}/>
          <Navbar.Brand href="/dashboard" style={{paddingLeft: 50+'px', color: 'white'}}>Loan Management User Portal</Navbar.Brand>
          </div>
          <Nav className="me-auto">
            <Nav.Link href="/dashboard"style={{color: 'white'}}>Dashboard</Nav.Link>
            <Nav.Link href="/login" style={{color: '#FFB500'}}>Logout</Nav.Link>
          </Nav>
      </Navbar>
    </>
  );
}

export default NavBar;