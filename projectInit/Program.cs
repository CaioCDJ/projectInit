using projectInit;

Console.Clear();

Project project = new Project
{
    name = "ola",
    type = "console"
};

await ProjectGem.newProject(project);
