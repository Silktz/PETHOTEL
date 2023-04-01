// :( 
Console.WriteLine("-----Pet Hotel SP-----");

Console.WriteLine("Espécie: ");
string Espécie = Console.ReadLine()!;

Console.WriteLine("Raça ");
string Raca =  Console.ReadLine()!;

Console.WriteLine("Nome: ");
string Nome = Console.ReadLine()!;

Console.WriteLine("Idade: ");
string Idade = Console.ReadLine()!;

Console.WriteLine("Cor: ");
string Cor = Console.ReadLine()!;

Console.WriteLine();


Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(@"
$$$$$$$\  $$$$$$$$\ $$$$$$$$\       $$\   $$\  $$$$$$\ $$$$$$$$\ $$$$$$$$\ $$\              $$$$$$\  $$$$$$$\        
$$  __$$\ $$  _____|\__$$  __|      $$ |  $$ |$$  __$$\\__$$  __|$$  _____|$$ |            $$  __$$\ $$  __$$\       
$$ |  $$ |$$ |         $$ |         $$ |  $$ |$$ /  $$ |  $$ |   $$ |      $$ |            $$ /  \__|$$ |  $$ |      
$$$$$$$  |$$$$$\       $$ |         $$$$$$$$ |$$ |  $$ |  $$ |   $$$$$\    $$ |            \$$$$$$\  $$$$$$$  |      
$$  ____/ $$  __|      $$ |         $$  __$$ |$$ |  $$ |  $$ |   $$  __|   $$ |             \____$$\ $$  ____/       
$$ |      $$ |         $$ |         $$ |  $$ |$$ |  $$ |  $$ |   $$ |      $$ |            $$\   $$ |$$ |            
$$ |      $$$$$$$$\    $$ |         $$ |  $$ | $$$$$$  |  $$ |   $$$$$$$$\ $$$$$$$$\       \$$$$$$  |$$ |            
\__|      \________|   \__|         \__|  \__| \______/   \__|   \________|\________|       \______/ \__| ");       

Console.ForegroundColor = ConsoleColor.DarkGray;                                                                                                                     
Console.WriteLine("==========================================================================================================");                                                                                                      
Console.ForegroundColor = ConsoleColor.DarkRed;                                                                            
Console.WriteLine("Espécie: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"" + Espécie.Trim().ToUpper());

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("==========================================================================================================");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Raça: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"" + Raca.Trim().ToUpper());

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("==========================================================================================================");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Atende pelo Nome: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"" + Nome.Trim().ToUpper());

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("==========================================================================================================");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Idade: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"" + Idade.Trim().ToUpper());

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("==========================================================================================================");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Cor: ");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"" + Cor.Trim().ToUpper());

Console.ForegroundColor = ConsoleColor.DarkGray;
Console.WriteLine("==========================================================================================================");

Console.ResetColor();