import React from 'react'
import axios from "axios";
import ProductEdit from './ProductEdit';



const baseURL = `api/AffiliateProducts`;
export default function ProductAdd() {

    const [title, settitle] = React.useState('');
    const [success, setsuccess] = React.useState(false);
    

 
    // function createPost() {
    //     axios
    //       .post(baseURL, {
    //         title: "Hello World!",
    //         body: "This is a new post."
    //       })
    //       .then((response) => {
    //        // setPost(response.data);
    //       });
    //   }
    
    const createPost = (e)=>{
        e.preventDefault();
        axios
        .post(baseURL,{title})
        .then((response) =>{
           // console.log(response.data);
            setsuccess(true);
        })

    }
    


    return (
        <>
        {success && <ProductEdit/> }
            <div className="col-md-9">
                <br></br>
                <br />
                <h2 className="poppins brand">Create Product </h2>
                <br />

                <form>
                    <div className="form-group">
                        <label htmlFor="title">Title</label>
                        <input type="text" onChange={(e)=>settitle(e.target.value)}   className="form-control"  placeholder="Enter product title" />
                    </div>
                    {/* <div className="form-group">
    <label htmlFor="productscript">Product HTML Script</label>
    <textarea className="form-control" id="productscript" rows={3} />
  </div> */}
                    <div className="form-group">
                        <br />
                        <button className="btn brandbg white" onClick={createPost} >NEXT</button>
                    </div>

                </form>
            </div>

        </>
    );
}
