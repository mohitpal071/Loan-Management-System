import React from 'react'
import styles from './RequestLoan.module.css'

const RequestLoan = () => {
  return (
    <div>
        <h1>Request Loan</h1>

            <div className={styles.formContainer}>
                <form>
                    <label for="empid">Employee ID</label>
                    <input type="text" id="empid" name="empid" required />
                    <label for="itemdescription">Item Description</label>
                    <input type="text" id="itemdescription" name="itemdescription" required />
                    <label for="itemcost">Item Cost</label>
                    <input type="text" id="itemcost" name="itemcost" required />
                    <label for="itemcategory">Item Type</label>
                    <input type="dropdown" id="itemcategory" name="itemcategory" required />
                    <label for="itemmake">Item Make</label>
                    <input type="dropdown" id="itemmake" name="itemmake" required />

                    <button type="submit">Apply Loan</button>
                </form>
            </div>
        </div>
  )
}

export default RequestLoan