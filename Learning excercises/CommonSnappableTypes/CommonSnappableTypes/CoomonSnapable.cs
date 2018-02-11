using System;

namespace CommonSnappableTypes
{
    public interface IPublicFuncionality
    {
        void DoIt();
    }
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CompanyInfoAttribute:Attribute
    {
        public string CompanyName { get; set; }
        public string CompanyUrl { get; set; }
    }
}
