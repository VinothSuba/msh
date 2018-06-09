using System.Web;
using System.Web.Optimization;

namespace MSH.Presentation
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/home").Include(
                      "~/Scripts/msh/custom.js"));

            BundleTable.Bundles.Add(new Bundle("~/bundles/scripts").Include("~/Scripts/jquery-3.2.1.min.js",
                                                                           "~/Scripts/popper.js",
                                                                        "~/Scripts/easing/easing.js",
                                                                        //"~/Scripts/bootstrap.min.js",
                                                                        "~/Scripts/bootstrap.bundle.min.js",
                                                                        "~/Scripts/plugins/easing/jquery.easing.min.js",
                                                                         "~/Scripts/plugins/greensock/TweenMax.min.js",
                                                                        "~/Scripts/plugins/greensock/TimelineMax.min.js",
                                                                        "~/Scripts/plugins/scrollmagic/ScrollMagic.min.js",
                                                                        "~/Scripts/plugins/greensock/animation.gsap.min.js",
                                                                        "~/Scripts/plugins/greensock/ScrollToPlugin.min.js",
                                                                        "~/Scripts/plugins/OwlCarousel2-2.2.1/owl.carousel.js",
                                                                        "~/Scripts/plugins/scrollTo/jquery.scrollTo.min.js",
                                                                        "~/Scripts/msh/scrolling-nav.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                       "~/Content/fonts/css/fontawesome-all.css",
                       "~/Content/carusel/owl.carousel.css",
                        "~/Content/carusel/owl.theme.default.css",
                         "~/Content/carusel/animate.css",
                      //"~/Content/contact_responsive.css",
                      //"~/Content/contact_styles.css",
                      //"~/Content/courses_responsive.css",
                      //"~/Content/courses_styles.css",
                      //"~/Content/elements_responsive.css",
                      //"~/Content/elements_styles.css",
                      "~/Content/SCSS/home.css",
                       "~/Content/SCSS/Responsive.css",
                        //"~/Content/news_post_responsive.css",
                        //"~/Content/news_post_styles.css",
                        //"~/Content/news_responsive.css",
                        //"~/Content/news_styles.css",
                        "~/Content/responsive.css"));
            //"~/Content/teachers_responsive.css",
            //"~/Content/teachers_styles.css"));

            BundleTable.EnableOptimizations = false;
        }
    }
}
