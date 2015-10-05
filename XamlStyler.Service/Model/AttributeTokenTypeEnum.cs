namespace XamlStyler.Core.Model
{
    public enum AttributeTokenTypeEnum
    {
        // ReSharper disable InconsistentNaming
        CLASS = 10,
        WPF_NAMESPACE = 20,
        OTHER_NAMESPACE = 21,
        KEY = 30,
        NAME = 40,
        ATTACHED_LAYOUT = 50,
        CORE_LAYOUT = 60,
        ALIGNMENT_LAYOUT = 70,
        PRIMARY_PROPERTIES = 1000,
        PRIMARY_EVENTS = 1500,
        OTHER = 2000,
        CLOSING = 3000,
        BLEND_RELATED = 10000
        // ReSharper restore InconsistentNaming
    }
}