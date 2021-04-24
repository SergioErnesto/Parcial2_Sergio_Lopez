using System;
using System.Reflection;

namespace Examen_Parcial2_Sergio_Lopez.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}