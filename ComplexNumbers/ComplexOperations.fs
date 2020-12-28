namespace ComplexNumbers

open System

module ComplexOperations =
   let Stringify (number: ComplexNumber) = $"({number.a}+{number.b}i)"
   let Add (x: ComplexNumber, y: ComplexNumber) = { a=x.a+y.a; b=x.b+y.b }
   let Substract (x: ComplexNumber, y: ComplexNumber) = { a=x.a-y.a; b=x.b-y.b }
   let Multiply (x: ComplexNumber, y: ComplexNumber) = { a=x.a*y.a-x.b*y.b; b=x.a*y.b+x.b*y.a }
   let Divide (x: ComplexNumber, y: ComplexNumber) = 
    let divider = y.a*y.a + y.b*y.b
    {a = (x.a*y.a + x.b*y.b)/divider
     b = (x.b*y.a - x.a*y.b)/divider}
   let Sqr (x: ComplexNumber) = Multiply(x,x)
   let Sqrt (x: ComplexNumber) = 
    let signOfImaginary = if x.b>=(float)0 then 1.0 else -1.0
    {a = Math.Sqrt((x.a + Math.Sqrt(x.a*x.a + x.b*x.b))/2.0)
     b = signOfImaginary * Math.Sqrt((-x.a + Math.Sqrt(x.a*x.a + x.b*x.b))/2.0)}