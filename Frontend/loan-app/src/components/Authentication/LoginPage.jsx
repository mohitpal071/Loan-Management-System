import React from "react";
import styles from "./LoginPage.module.css";
import { Form, Button } from "react-bootstrap";

//function to send data to backend
const handleSubmit = (event) => {
  event.preventDefault();
  const data = new FormData(event.target);
  fetch("/api/login", {
    method: "POST",
    body: data,
  });
};

const LoginPage = () => {
  return (
    <div className={styles.loginPage}>
      <div className={styles.formContainer}>
        <div className={styles.leftHalf}>
          <div className={styles.logo}>
            <img src="./assets/wells.png" width={300}/>
          </div>
        </div>
        <div className={styles.rightHalf}>
          <div className={styles.form}>
          <h1>Welcome!</h1>
          <Form className={styles.formGroup} onSubmit={handleSubmit}>
            <Form.Group controlId="formBasicUsername">
              <Form.Label>Username</Form.Label>
              <Form.Control type="text" placeholder="Enter username" name="username" />
            </Form.Group>
            <Form.Group controlId="formBasicPassword">
              <Form.Label>Password</Form.Label>
              <Form.Control type="text" placeholder="Enter password" name="password" />
            </Form.Group>
            <div className={styles.buttonContainer}>
              <Button variant="danger" type="submit">
                Login
              </Button>
            </div>
          </Form>
          </div>
        </div>
    </div>
    </div>
  );
};

export default LoginPage;
