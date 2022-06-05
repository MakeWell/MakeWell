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
import { ApplicationTitleComponent } from './components/application-title/application-title.component';
import { ApplicationNavigationComponent } from './components/application-navigation/application-navigation.component';
import { PhysicalExaminationItemComponent } from './components/physical-examination-item/physical-examination-item.component';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { RequestFormComponent } from './pages/home-page/contents/request-form/request-form.component';
@NgModule({
  declarations: [
    AppComponent,
    ApplicationTitleComponent,
    ApplicationNavigationComponent,
    PhysicalExaminationItemComponent,
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
