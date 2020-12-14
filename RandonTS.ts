var msg:string = "Hello World";
const msg1:string = "Hello";

msg = "Something";
 let myNumber:number = 5;

console.log(myNumber);

class Greet {
    greet():void {
        console.log("Hi This is my Class")
    }
}

let instance = new Greet()
instance.greet()

// [LOG]: 5 
// [LOG]: 5 
// [LOG]: "Hi This is my string" 
// [LOG]: 5 
// [LOG]: "Hi This is my string" 
// [LOG]: 5
