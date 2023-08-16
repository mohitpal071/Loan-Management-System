import axios from 'axios';


const URL = 'http://localhost:16710/api'

export async function login(data)
{
    try{
        const res = await axios.post(`${URL}/Employees/login`,{
            ...data,
            
    })
    return{success:true,data:res.data}
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

