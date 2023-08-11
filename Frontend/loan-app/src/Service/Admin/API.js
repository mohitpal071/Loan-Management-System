import axios from 'axios'

const URL = 'http://localhost:3000'

export async function signup(data){
    try{
        const res = await axios.post(`${URL}/signup`,{
            ...data,
        })
        // const token = res.data.token
        return {success:true}
    }
    catch(error){
        if(error.response){
            return {success:false,error:error.response.data.error}
        }
        else{
            return {
                success :false,
                error  : "Error occured while sending the request"
            }
        }
    }
}