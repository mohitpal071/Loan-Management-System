import axios from 'axios'

const URL = 'http://localhost:5068/api'

export async function signup(data){
    try{
        const res = await axios.post(`${URL}/Employees`,{
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