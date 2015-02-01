using UnityEngine;
using System.Collections;

public class CSS
{

    private float _width;
    private float _minwidth;
    private float _maxwidth;
    private float _height;
    private float _minheight;
    private float _maxheight;
    private float _fontsize;

    public CSS() {
        _width = 0;
        _minwidth = -1;
        _maxwidth = -1;
        _height = 0;
        _minheight = -1;
        _maxheight = -1;
        _fontsize = 1;
    }

    public float width()
    {
        if (this._width > _maxwidth && _maxwidth != -1)
            return _maxwidth;
        else if (this._width < _minwidth && _minwidth != -1)
            return _minwidth;
        else
            return this._width;
    }
    public CSS width(string w)
    {
        if (w.EndsWith("px"))
        {
            w = w.Replace("px", "");
            this._width = float.Parse(w);
        }
        else if (w.EndsWith("%"))
        {
            w = w.Replace("%", "");
            this._width = (float)Screen.width * float.Parse(w) / 100;
        }
        return this;
    }
    public CSS minwidth(float mw)
    {
        _minwidth = mw;
        return this;
    }
    public CSS maxwidth(float mw)
    {
        _maxwidth = mw;
        return this;
    }

    public float height()
    {
        if (this._height > _maxheight && _maxheight != -1)
            return _maxheight;
        else if (this._height < _minheight && _minheight != -1)
            return _minheight;
        else
            return this._height;
    }
    public CSS height(string w)
    {
        if (w.EndsWith("px"))
        {
            w = w.Replace("px", "");
            this._height = float.Parse(w);
        }
        else if (w.EndsWith("%"))
        {
            w = w.Replace("%", "");
            this._height = (float)Screen.height * float.Parse(w) / 100;
        }
        return this;
    }
    public CSS minheight(float mw)
    {
        _minheight = mw;
        return this;
    }
    public CSS maxheight(float mw)
    {
        _maxheight = mw;
        return this;
    }

    public CSS fontsize(float p)
    {
        this._fontsize = p / 100;
        return this;
    }

    public int fontsize(GUIStyle g, string t)
    {
        return (int)(g.fontSize * this._fontsize / (g.CalcSize(new GUIContent(t)).x / (float)Screen.width));
    }
}
