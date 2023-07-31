using Lista_2;

public class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Elias";
        aluno1.cpf = "2323322303-902";
        Aluno aluno2 = new Aluno(11, "bertano", "233233232-49", new DateOnly (1995, 05, 23));


        List<Aluno> alunos = new List<Aluno>();
        alunos.Add(aluno1);
        alunos.Add(aluno2);

        foreach (Aluno a in alunos)
        { 
            Console.WriteLine($"O nome é {a.Nome} e seu cpf: { a.cpf}");
        }
    }/// prpgrama que pede para os usuario que pede os dados para o aluno, exe: informa... aluno1, inserir na lista, perguntar se tem desejo de cadrastrar de um  aluno, esse processo vai ocorrer quantos quiser, faz um forech e imprimir todos os alunos pelo forech
}


















//List <string> lista1 = new List<string>();

//List<string> lista2 = new List<string>() { "Alice", "Maria" };
//lista1.Add("João");
//List<Aluno> alunos = new List<Aluno>();

