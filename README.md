# Angular4.NetMVC

SEO Implimantation:

We can add SEO support to the project by adding the following things.

    1) we need to pre render the app before pushing to the client using platform-server package which is needed for server side rendering.
    npm install --save @angular/platform-server @angular/animations
    and also create one module.server.ts and server.ts for server side rendering  for more information please visit below link:
    https://coursetro.com/posts/code/68/Make-your-Angular-App-SEO-Friendly-(Angular-4-+-Universal)
	
    2)Add below code to very page:
	
    import { Meta, Title } from '@angular/platform-browser';
    public page:any = { "title": "CNN Podcast", "decsription": "CNN PODCAST offer live news", "auther": "Betsson.com", "keywords":      "Betsson cnn news, Betsson live, Betsson news online"};
    this.setSiteSEO(this.page);
    setSiteSEO(data: any) {
        this.title.setTitle(data.title);
        this.meta.addTags([
            { name: 'auther', content: data.auther },
            { name: 'keyword', content: data.keywords },
            { name: 'description', content: data.description }
        ])
    }
