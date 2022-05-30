//*********
// modules
//*********
// essential
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LayoutModule } from '@angular/cdk/layout';
// routing
import { AppRoutingModule } from './app-routing.module';
// application
import { ShoulderModule } from './modules/shoulder/shoulder.module';
// mat
import { AppMatModule } from './app-mat.module';
//************
// components
//************
// root
import { AppComponent } from './app.component';
// application
import { ApplicationTitleComponent } from './components/application-title/application-title.component';
import { ApplicationNavigationComponent } from './components/application-navigation/application-navigation.component';
import { PhysicalExaminationItemComponent } from './components/physical-examination-item/physical-examination-item.component';
import { NavLinkComponent } from './nav-link/nav-link.component';
@NgModule({
  declarations: [
    AppComponent,
    ApplicationTitleComponent,
    ApplicationNavigationComponent,
    PhysicalExaminationItemComponent,
    NavLinkComponent,
   ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    LayoutModule,
    AppMatModule,
    ShoulderModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
