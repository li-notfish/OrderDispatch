namespace OrderDispatch.WebApi.Attributes
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple =true,Inherited =false)]
    public sealed class AppJsonSerializerAttribute : Attribute
    {
    }
}
