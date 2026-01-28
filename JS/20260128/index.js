let x=5;
let y="5";

console.log(x+y);

function fuggvenynev(n1,n2){
    return n1+n2;
}

console.log(fuggvenynev(3,4));

let tomb=[1,2,"szzia", false];

console.log(tomb);

for(let i=0; i<tomb.length; i++){
    console.log(tomb[i]);
}

let z=5;

if(z%2==0){
    console.log("z páros");
}
else{
    console.log("z páratlan");
}

// egysoros

/*
több soros
komment
*/

// óra vége: prog tételek megírása önállóan


function max_kiv(tomb){
    let max_index=0;
    let max_ert=tomb[0];
    for(let i=1; i<tomb.length; i++){
        if(max_ert<tomb[i]){
            max_ert=tomb[i];
            max_index= i;
        }
    }
    return [max_index, max_ert];
}

let t1=[2,3,0,3,8,0,6,8,5];

function q(x){
    console.log(x);
}

q(max_kiv(t1));

function szelso_ertek_kiv(tomb, func){
    let index=0;
    let ert=tomb[0];
    for(let i=1; i<tomb.length; i++){
        if(func(ert,tomb[i])){
            ert=tomb[i];
            index= i;
        }
    }
    return [index, ert];
}

q(szelso_ertek_kiv(t1, (n1,n2)=>n1>n2)); //minimum kiv
q(szelso_ertek_kiv(t1, (n1,n2)=>n1<n2)); //maximum kiv


q(szelso_ertek_kiv(t1, (n1,n2)=>n1>=n2)); //utolsó minimum kiv
q(szelso_ertek_kiv(t1, (n1,n2)=>n1<=n2)); //utolsó maximum kiv


let zzz=5; //lokális változó

var xxxx=15; //globális változó

const KONSTANS="szia";

const PI=3.14; //nagybetűs változó név = const

//PI+=6; // hiba!

let objektum= {
    name: "Zoli",
    kor: 3,
    getName() {
        return this.name;
    },
    getKor() {
        return 32;
    }
}

q(objektum.name);
q(objektum.getName());
q(objektum.getKor());