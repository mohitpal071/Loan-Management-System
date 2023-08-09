import React from 'react'

const LoginPage = () => {
  return (
    <div>
        <div className="container">
                    <h1>Login</h1>
                    <form>
                        <div className="form-group">
                            <div className='row'>
                            <label htmlFor="username">Username</label>
                            <input type="text" className="form-control" id="username" placeholder="Enter username" />
                            </div>
                            <div className='row'>
                            <label htmlFor="password">Password</label>
                            <input type="password" className="form-control" id="password" placeholder="Enter password" />
                            </div>
                            <button type="submit" className="btn btn-primary">Login</button>
                        </div>
                    </form>
        </div>
    </div>
  )
}

export default LoginPage