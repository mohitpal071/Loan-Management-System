import React from "react";
import NavBar from "../NavBar/NavBar";
import styles from "./ApplyLoan.module.css";
import { Form, Button } from "react-bootstrap";
import { Dropdown } from "react-bootstrap";

const ApplyLoan = () => {
  return (
    <div>
      <NavBar />
      <div className={styles.applyLoan}>
        <form className={styles.formContainer}>
        <div className={styles.formHeader}>
            <h2>Apply for Loan</h2>
        </div>
          <Form className={styles.formGroup}>
            <div className={styles.group1}>
              <Form.Group controlId="empid">
                <Form.Label>Employee ID:</Form.Label>
                <Form.Control
                  autocomplete="off"
                  type="text"
                  placeholder="Employee ID"
                  name="Employee ID:"
                />
              </Form.Group>
              <br />
              <Form.Group controlId="itemdesc">
                <Form.Label>Item Description:</Form.Label>
                <Form.Control
                  autocomplete="off"
                  type="text"
                  placeholder="Item Description"
                  name="Item Description:"
                />
              </Form.Group>
            </div>

            <div className={styles.group2}>
              <Form.Group controlId="itemcategory" className={styles.dropdown}>
                <Form.Label>Item Category:</Form.Label>
                <select aria-label="Item Category">
                  <option>Select item category</option>
                  <option value="1">Furniture</option>
                  <option value="2">Electronics</option>
                  <option value="3">Appliances</option>
                </select>
              </Form.Group>
              <br />
              <Form.Group controlId="itemcost">
                <Form.Label>Item Cost:</Form.Label>
                <Form.Control
                  autocomplete="off"
                  type="text"
                  placeholder="Item Cost:"
                  name="Item Cost"
                />
              </Form.Group>
            </div>
          </Form>

          <div className={styles.bottomGroup}>
            <Form.Label>Item Make:</Form.Label>
            <select aria-label="Item Make">
              <option>Select Item Make</option>
              <option value="1">Wooden</option>
              <option value="2">Steel</option>
              <option value="3">Plastic</option>
            </select>
          </div>
          <Button variant="success" type="submit">
            Apply Loan
          </Button>
        </form>
      </div>
    </div>
  );
};

export default ApplyLoan;
