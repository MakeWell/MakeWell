//*********
// modules
//*********
// essential
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LayoutModule } from '@angular/cdk/layout';
// routing
import { AppRoutingModule } from './modules/app-routing.module';
// mat
import { AppMatModule } from './modules/app-mat.module';
//************
// components
//************
// root
import { AppComponent } from './app.component';
// application
import { HomePageComponent } from './pages/home-page/home-page.component';
import { RequestFormComponent } from './pages/home-page/contents/request-form/request-form.component';
@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    RequestFormComponent,
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    LayoutModule,
    AppMatModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
