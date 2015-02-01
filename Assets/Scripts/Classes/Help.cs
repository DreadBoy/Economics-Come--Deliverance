using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Help
{
    public String title { get; set; }
    public String body { get; set; }

    public Help(String title, String body)
    {
        this.title = title;
        this.body = body;
    }
}
