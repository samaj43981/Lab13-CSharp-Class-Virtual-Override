﻿// โค้ดที่ไม่ได้อยู่ในคลาสหรือ namespace ควรอยู่ตรงนี้
AnimalSound sound = new AnimalSound();
Animal dog = new Dog();
Animal cat = new Cat();

sound.PlaySound(dog);
sound.PlaySound(cat);

public class Animal
{
    public virtual void makeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class AnimalSound
{
    public void PlaySound(Animal animal)
    {
        animal.makeSound();
    }
}