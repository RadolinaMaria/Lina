using System;


namespace Phone_Book_2
{
    public class Contact
{
    private Uri picture;

    public Uri Picture
    {
        get { return picture; }
        set { picture = value; }
    }

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private string phone;

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public Contact(Uri picture, string name, string phone)
    {
        this.picture = picture;
        this.name = name;
        this.phone = phone;
    }
}
}
