import React from "react";
import styles from "./LoginPage.module.css";
import { Form, Button } from "react-bootstrap";
import { useState } from "react"
import { adminlogin } from '../../../Services/Admin/login';

const AdminLogin = () => {
  const [form, setForm] = useState({
    username: "",
    password: ""
  });

  const handleChange = (event) => {
    console.log(event.target.id + " " + event.target.value);
    setForm({
      ...form,
      [event.target.id]: event.target.value,
    });
    console.log(form)
  } 


  const handleSubmit = (event) => {
    event.preventDefault();
    adminlogin(form).then((res)=>{
    console.log(form)
    if(res.success == true)
    {
      window.location.href = "/admin/dashboard";
    }
    
    else 
    {
     alert("invalid Credentials"); 
    }
    })
    
    
  }

  return (
    <div className={styles.loginPage}>
      <div className={styles.formContainer}>
        <div className={styles.leftHalf}>
          <div className={styles.logo}>
            <img src="../assets/wells.png" width={300}/>
          </div>
        </div>
        <div className={styles.rightHalf}>
          <div className={styles.form}>
          <h1>Welcome admin!</h1>
          <form>
          <Form className={styles.formGroup} >
            <Form.Group controlId="username">
              <Form.Label>Username:</Form.Label>
              <Form.Control value={form.username} onChange={handleChange} autocomplete="off" type="text" placeholder="Enter username" name="username" />
            </Form.Group>
            <Form.Group controlId="password">
              <Form.Label>Password:</Form.Label>
              <Form.Control value={form.password} onChange={handleChange} autocomplete="off" type="password" placeholder="Enter password" name="password" />
            </Form.Group>
            <br />
            <div className={styles.buttonContainer}>
              <Button variant="danger" type="submit" onClick={handleSubmit}>
                Login
              </Button>
            </div>
          </Form>
          </form>
          
          </div>
        </div>
    </div>
    </div>
  );
};

export default AdminLogin;
