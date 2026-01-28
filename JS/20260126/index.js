let a = 5;
console.log(a);
console.log((a+"5")*4);

function f(a,b){
    return a+b;
}

console.log(f(2,3));
console.log(f(2,"3"));
console.log(f("2","3"));
console.log(f(2,3.2));

function kiir(x){
    let elvalaszto="-----------------------------------";
    console.log(elvalaszto);
    console.log(x);
    console.log(elvalaszto);
}

kiir("Szia Béla!");
let h= 7;
kiir(h);

let tomb=[1,2,"szzia", false];

kiir(tomb);

let dict={
    "név":"Béla",
    "kor":21,
};
kiir(dict);

kiir(tomb[2]);

kiir(dict["név"]);

// egysoros komment

/*
több
soros
komment
*/

const aaa=5;
aaa+=7;
console.log(aaa);