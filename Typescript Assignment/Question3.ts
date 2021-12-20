/*3)write a function to find a factorial of number*/
function factorial(Num:number)
{

    
    let i;
    let sum=1;
    for( i=1;i<=Num;i++)
    {
     sum=sum*i;
    }
    console.log(sum);

}
factorial(4);
