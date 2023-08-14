import react from 'react'
import axios from 'axios';

const URL = 'http://localhost:16710/api'

export async function signup(data){
    try{
        const res = await axios.post(`${URL}/Employees`,{
            ...data,
        })
        // const token = res.data.token
    }

    catch(error){
        if(error.response){
            return {success:false,error:error.response.data.error}
        }
        else{
            return{
                success:false,
                error: "Error occurred while sending hte request"
            }
        }
    }
}