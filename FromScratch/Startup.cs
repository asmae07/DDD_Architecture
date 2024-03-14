namespace Api_Scratch
{
    public class Startup
    {
        //Prop
        public IConfiguration Configuration { get; set; }

        // Constructeur 
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // IOC 
        public void ConfigureServices(IServiceCollection services)
        {
            //registers a single instance of the service for the entire lifetime of the application
           
            services.AddAutoMapper(typeof(Program));
            services.AddControllers();
            services.AddSingleton(Configuration);
            services.AddSwaggerGen();
            services.AddMvc();
        }

        //MiddleWare 
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
               
            }
            //it maps controllers to handle incoming requests.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        
    }
}
