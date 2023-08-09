import React from "react";
import "./Dashboard.css";
//function to send data to backend
const handleSubmit = (event) => {
  event.preventDefault();
  const data = new FormData(event.target);
  fetch("/api/login", {
    method: "POST",
    body: data,
  });
};

const Dashboard = () => {
  return (
    <div class="login-container">
      <div>
        <div class="form-header">
          <h1>User Dashboard</h1>
        </div>
        <div class="form-container">
          <button type="submit" onSubmit={handleSubmit}>
            View Loans
          </button>

          <button type="submit" onSubmit={handleSubmit}>
            Apply for Loan
          </button>

          <button type="submit" onSubmit={handleSubmit}>
            View Items Purchased
          </button>
        </div>
      </div>
    </div>
  );
};

export default Dashboard;
