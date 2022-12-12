using System;

namespace VYaml.Annotations
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, Inherited = false)]
    public class YamlObjectAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class YamlMemberAttribute : Attribute
    {
        public string? Name { get; }

        public YamlMemberAttribute(string? name = null)
        {
            Name = name;
        }
    }

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public sealed class YamlIgnoreAttribute : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
    public sealed class YamlConstructorAttribute : Attribute
    {
    }

    /// <summary>
    /// Preserve for Unity IL2CPP(internal but used for code generator)
    /// </summary>
    /// <remarks>
    /// > For 3rd party libraries that do not want to take on a dependency on UnityEngine.dll, it is also possible to define their own PreserveAttribute. The code stripper will respect that too, and it will consider any attribute with the exact name "PreserveAtribute" as a reason not to strip the thing it is applied on, regardless of the namespace or assembly of the attribute.
    /// </remarks>
    public sealed class PreserveAttribute : Attribute
    {
    }
}