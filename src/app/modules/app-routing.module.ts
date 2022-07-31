import { NgModule } from '@angular/core';
// routing modules
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
// pages
import { HomePageComponent } from '../pages/home-page/home-page.component';
import { PageNotFoundComponent } from '../pages/page-not-found/page-not-found.component';
// routes
const routes: Routes = [
  // Home
  { path: 'home', component: HomePageComponent },
  { path: '',  redirectTo: 'home', pathMatch: 'full' },
  // Wildcard route for a 404 page
  { path: '**', component: PageNotFoundComponent }
]
@NgModule({
  imports: [
    RouterModule.forRoot(routes, {
      paramsInheritanceStrategy: 'always',
      preloadingStrategy: PreloadAllModules
    })
  ],
  exports: [RouterModule],
})
export class AppRoutingModule {}
