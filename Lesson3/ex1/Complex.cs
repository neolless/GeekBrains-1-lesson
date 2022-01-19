

struct Complex

{

   

    public int a, b; //в этой переменной храним числа в публичном доступе
     public Complex (int re, int im) //то что передали как аргумент метода храним в "а" и "b"   
    {
    this.a =re; //конкретно указываем на число
    this.b = im;
    }   
     public Complex Sum(Complex z) // метод сложения комплексных чисел
    {
        Complex result;
        result = new(this.a+z.a, this.b+z.b);
        return result;  
    }
      public Complex Des(Complex z) // метод вычитания комплексных чисел
    {
        Complex result;
        result = new(this.a-z.a, this.b-z.b);
        return result;  
    }
         public Complex Mult(Complex z) // метод умножения комплексных чисел
    {
        Complex result;
        result = new(this.a*z.a - this.b*z.b , this.a*z.b + this.b*z.a);
        return result;  
    }

     public override string ToString ()
    {
       string  s;
        if (b<0) s= $"{a} - {-b}i";
        else s=$"{a} + {b}i";
        return s; // описана логика обработки чисел
    }

}  
