import { NgModule } from '@angular/core';
// routing modules
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';
// pages
import { HomePageComponent } from './pages/home-page/home-page.component';
import { PageNotFoundComponent } from './pages/page-not-found/page-not-found.component';
// chapters
import { ShoulderComponent } from './modules/shoulder/shoulder.component';
// routes
const routes: Routes = [
  //
  { path: 'home', component: HomePageComponent },
  //
  { path: '',  redirectTo: 'home', pathMatch: 'full' },
  // shoulder module
  {
    path: 'shoulder',
    component: ShoulderComponent,
    loadChildren: () => import('./modules/shoulder/shoulder.module').then(m => m.ShoulderModule)
  },
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
