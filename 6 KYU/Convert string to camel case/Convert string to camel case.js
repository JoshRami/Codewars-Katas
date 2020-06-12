function toCamelCase(str){
    if(str.length === 0){
        return '';
    }
    let words = str.split(/[-_]/).map(word => `${word.charAt(0).toUpperCase()}${word.slice(1)}`).join('');
    return str[0] === words[0].toUpperCase() ? words : `${str[0]}${words.slice(1)}`;
 }