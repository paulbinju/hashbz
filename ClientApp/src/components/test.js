import React, {useState} from 'react'

export function Test() {

    const[count, setCount] = useState(0);


    return (
        <>
        <h1>Hello test</h1>
        <button onClick={()=>setCount(count+1)}></button>
        </>
    );
}
 

