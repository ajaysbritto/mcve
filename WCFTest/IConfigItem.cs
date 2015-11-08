namespace BusinessObjects
{
    public interface IConfigItem
    {
        string ModuleName { get; set; }
        void PutValue(string key, string value);
        string GetValue(string key);
    }
}
