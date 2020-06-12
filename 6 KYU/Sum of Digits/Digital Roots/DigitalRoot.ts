export const digitalRoot = (n:number):number => {
    let sum: number = sumValues(n);
    return isSingleDigit(n) ? n : isSingleDigit(sum) ? sum : digitalRoot(sum);  
}; 
function sumValues(actualNum: number):number{
    return actualNum.toString().split('').map(digit => Number(digit)).reduce((acumulator: number, currentValue: number) => acumulator + currentValue)
}
function isSingleDigit(n: number){
    return n > 0 && n < 10
}