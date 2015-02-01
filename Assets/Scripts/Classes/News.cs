using System;
using System.Collections;

public class News
{
    public String title { get; set; }
    public String message { get; set; }
    public NewsType type { get; set; }
    public EffectType effect { get; set; }

    public News(String title, String message, NewsType type, EffectType effect)
    {
        this.title = title;
        this.message = message;
        this.type = type;
        this.effect = effect;
    }

}
