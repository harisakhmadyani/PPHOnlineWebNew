// function thousand_separator_js(num){
//     var reverse = num.toString().split('').reverse().join(''),
//     thousand  = reverse.match(/\d{1,3}/g);
//     thousand_separator  = thousand.join(',').split('').reverse().join('');
//     return thousand_separator;
// }

function remove_thousand_separator_js(num){
    var res = num.replace(/\,/g, '');
    var res2 = res.replace(/\,/g, '.');
  	return res2;
}

function check_decimals(num){
    var res = num.split(',');
    return res[1];
}

function remove_decimals(num){
    var res = num.replace(/\./g, '');
    return res;
}