import React from 'react'
import styles from './UserSignup.module.css'
import AdminNavBar from '../Admin/AdminNavBar/AdminNavBar'
import { Form, Button } from 'react-bootstrap'
import { useState } from 'react';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';


const UserSignup = () => {
  const [dobDate, setdobDate] = useState(new Date());
  const [dojDate, setdojDate] = useState(new Date());

  const designation = ['Program Associate', 'Manager', 'CEO'];
  const dept = ['Finance', 'Technology', 'Sales'];
  const gender = ['Male', 'Female', 'Other'];

  const handleDobChange = (date) => {
    console.log(date.target.value);
    setdobDate(date.target.value);
  };

  const handleDojChange = (date) => {
    console.log(date.target.value);
    setdojDate(date.target.value);
  };

  const [form, setForm] = useState({
    empid: "",
    empname: "",
    dept: "",
    designation: "",
    dob: "",
    doj: "",
    password: "",
    cpassword: "",
    gender: "",
  });

  const handleChange = (event) => {
    console.log(event.target.id + " " + event.target.value);
    setForm({
      ...form,
      [event.target.id]: event.target.value,
    });

    console.log(form)
  }

  const handleDropdownChange = (event) => {
    console.log(event.target.id + " " + event.target.value);
    form[event.target.id] = event.target.value;
    setForm({
      ...form,
    });
  }

  function padTo2Digits(num) {
    return num.toString().padStart(2, '0');
  }

  function formatDate(date) {
    return [
      padTo2Digits(date.getDate()),
      padTo2Digits(date.getMonth() + 1),
      date.getFullYear(),
    ].join('/');
  }

  const handleSubmit = (event) => {
    event.preventDefault();
    form.dept = dept[parseInt(form.dept)];
    form.designation = designation[parseInt(form.designation)];
    form.gender = gender[parseInt(form.gender)];
    form.dob = formatDate(new Date(dobDate));
    form.doj = formatDate(new Date(dojDate));
    form.password = form.password.toString();
    form.cpassword = form.cpassword.toString();

    if(form.password !== form.cpassword) {
      alert("Passwords do not match");
      return;
    }

    console.log(form);
  }

  return (
    <div>
      <AdminNavBar />
      <div className={styles.addUser}>
        <form className={styles.formContainer}>
        <div className={styles.formHeader}>
            <h2>Register</h2>
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
                  value={form.empid}
                  onChange={handleChange}
                />
              </Form.Group>
              <br />
              <Form.Group controlId="empname">
                <Form.Label>Employee Name:</Form.Label>
                <Form.Control
                  autocomplete="off"
                  type="text"
                  placeholder="Employee Name"
                  name="Employee Name:"
                  value={form.empname}
                  onChange={handleChange}
                />
              </Form.Group>
              <br />
              <Form.Group controlId="dept" className={styles.dropdown}>
                <Form.Label>Department:</Form.Label>
                <select id="dept" aria-label="Department" value={form.dept} onChange={handleDropdownChange}>
                  <option>Select Department</option>
                  <option value="0">Finance</option>
                  <option value="1">Technology</option>
                  <option value="2">Sales</option>
                </select>
              </Form.Group> 
              <br />  
              <Form.Group controlId="password">
                <Form.Label>Password:</Form.Label>
                <Form.Control
                  autocomplete="off"
                  type="password"
                  placeholder="Password"
                  name="Password:"
                  value={form.password}
                  onChange={handleChange}
                />
              </Form.Group>          
            </div>

            <div className={styles.group2}>
              <Form.Group controlId="designation" className={styles.dropdown}>
                <Form.Label>Designation:</Form.Label>
                <select id="designation" aria-label="Designation" value={form.designation} onChange={handleDropdownChange}>
                  <option>Select Designation</option>
                  <option value="0">Program Associate</option>
                  <option value="1">Manager</option>
                  <option value="2">CEO</option>
                </select>
              </Form.Group>
              <br />
              <Form.Group controlId="dob" className={styles.dropdown}>
                <Form.Label>Date of Birth:</Form.Label>
                <Form.Control type="date" value={dobDate} onChange={handleDobChange} />
              </Form.Group>
              <br />
              <Form.Group controlId="doj" className={styles.dropdown}>
                <Form.Label>Date of Joining:</Form.Label>
                <Form.Control dateFormat="dd-MM-yyyy" type="date" value={dojDate} onChange={handleDojChange} />
              </Form.Group>
              <br />
              <Form.Group controlId="cpassword">
                <Form.Label>Password:</Form.Label>
                <Form.Control
                  autocomplete="off"
                  type="password"
                  placeholder="Confirm Password"
                  name="Confirm Password:"
                  value={form.cpassword}
                  onChange={handleChange}
                />
              </Form.Group>
            </div>
          </Form>

          <div className={styles.bottomGroup}>
            <Form.Group controlId="gender" className={styles.dropdown}>
                <Form.Label>Gender:</Form.Label>
                <select id="gender" aria-label="Gender" value={form.gender} onChange={handleDropdownChange}>
                  <option>Select Gender</option>
                  <option value="0">Male</option>
                  <option value="1">Female</option>
                  <option value="2">IDk</option>
                </select>
              </Form.Group>
          </div>
          <Button variant="success" type="submit" onClick={handleSubmit}>
            Register
          </Button>
        </form>
      </div>
    </div>
  )
}

export default UserSignup