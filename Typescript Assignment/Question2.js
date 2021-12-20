/*2) write function to calculate to find discountedbill from billamount as per given condition
  If amount is <10000 the 5%
 if amount is>10000 and  <20000 the 10%
 if amount is >20000 and  <30000 the 15%
  If amount is >30000 the 25%*/
function Discount(amt) {
    var dis;
    var Final_Amount;
    if (amt <= 10000) {
        dis = amt * 0.5;
    }
    else if (amt > 10000 && amt <= 20000) {
        dis = amt * 0.10;
    }
    else if (amt > 20000 && 30000) {
        dis = amt * 0.15;
    }
    else if (amt > 30000) {
        dis = amt * 0.25;
    }
    Final_Amount = amt - dis;
    console.log("Youre Billing Amount is " + Final_Amount);
}
Discount(25000);
