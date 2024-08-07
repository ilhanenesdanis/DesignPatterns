namespace FactoryMethod
{
    public abstract class Website
    {
        public abstract void CreatePages();
    }
    public class WebsiteECommerce : Website
    {
        public override void CreatePages()
        {
            //E-ticaret sayfası için özelleştirilmiş kodlar
            Console.WriteLine("E-Ticaret sitesi oluşturuldu");

        }
    }
    public class WebsiteBlog : Website
    {
        public override void CreatePages()
        {
            //blog sayfası için gerekli kodlar
            Console.WriteLine("Blog Sitesi Oluşturuldu");
        }
    }
    public abstract class WebsiteFactory
    {
        public abstract Website CreateWebSite();
    }
    public class WebSiteFactoryECommerce : WebsiteFactory
    {
        public override Website CreateWebSite()
        {
            
            return new WebsiteECommerce();
        }
    }
    public class WebSiteFactoryBlog : WebsiteFactory
    {
        public override Website CreateWebSite()
        {
            return new WebsiteBlog();
        }
    }
}
