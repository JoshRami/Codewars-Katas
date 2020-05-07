function solution(str){
    let split = [];
    if(str.length % 2 == 1){
       str += "_";
    }
    for(let i = 0; i < str.length; i+=2){
      split.push(str.substring(i, i+2));
    }
    return split; 
}
