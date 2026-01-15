namespace ConsoleApp1;

public class Delegate
{
    public delegate void DamageHandler(int dmg);
    public event DamageHandler? OnDamage;

    private void TakeDamage(int amount) => OnDamage?.Invoke(amount);

    public static void Example()
    {
        var player = new Delegate();
        player.OnDamage += dmg => Console.WriteLine($"Player hit for {dmg}");
        player.TakeDamage(10); // 觸發事件與 lambda
    }
}